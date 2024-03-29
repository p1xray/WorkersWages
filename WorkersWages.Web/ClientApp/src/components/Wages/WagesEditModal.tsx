﻿import { AisModal } from "@ais-gorod/react-ui";
import { useCallback, useEffect, useState } from "react";
import { WageEditRequest, WorkersWagesApiClient } from "../../services/WorkersWagesApiClient";
import { WagesEditForm } from './WagesEditForm';

interface Props {
    id: number;
    onHide: () => void;
    onDataChanged: () => void;
}

const apiClient = new WorkersWagesApiClient('/extapi');

export const WagesEditModal = (props: Props) => {
    const id = props.id;
    const [wageInfo, setWageInfo] = useState<WageEditRequest>();
    useEffect(() => {
        if (!id) return;

        apiClient.wagesDetails(id).then((r) => setWageInfo(
            new WageEditRequest({
                workerLastName: r.workerLastName,
                manufactoryId: r.manufactoryId,
                professionId: r.professionId,
                rank: r.rank,
            })
        ));
    }, [id])

    const propsOnDataChanged = props.onDataChanged;
    const propsOnHide = props.onHide;
    const handleSubmit = useCallback(async (data: WageEditRequest) => {
        if (!id) return;

        await apiClient.wagesEdit(id, data).then((_) => {
            propsOnHide();
            propsOnDataChanged();
        });
    }, [id, history, propsOnDataChanged, propsOnHide]);

    if (!wageInfo) return null;

    return (
        <AisModal show={true} onHide={props.onHide} title="Редактирование заработной платы">
            <WagesEditForm onSubmit={handleSubmit} data={wageInfo} />
        </AisModal>
    );
};

WagesEditModal.diaplayName = 'WagesEditModal';
